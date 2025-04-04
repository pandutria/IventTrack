package com.example.inventtrack.ui.fragment

import android.app.Activity
import android.os.AsyncTask
import android.os.Bundle
import android.text.Editable
import android.text.TextWatcher
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.inventtrack.R
import com.example.inventtrack.adapter.ProductAdapter
import com.example.inventtrack.databinding.FragmentHomeBinding
import com.example.inventtrack.databinding.ItemProductBinding
import com.example.inventtrack.model.Category
import com.example.inventtrack.model.Product
import com.example.inventtrack.model.User
import com.example.inventtrack.network.dbConnection
import com.example.inventtrack.util.support
import java.io.IOException
import java.sql.Connection
import java.sql.PreparedStatement
import java.sql.ResultSet
import java.sql.Statement

class HomeFragment : Fragment() {
    lateinit var binding: FragmentHomeBinding
    var product_id = 0
    var product_price = 0

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        binding = FragmentHomeBinding.inflate(inflater, container, false)

        binding.layout.visibility = View.GONE
        binding.btnRegister.setOnClickListener {
            sendData(this).execute()
        }

        binding.etSearch.addTextChangedListener(object: TextWatcher {
            override fun beforeTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {

            }

            override fun onTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {
                showData(this@HomeFragment).execute()
            }

            override fun afterTextChanged(p0: Editable?) {

            }
        })

        showData(this).execute()
        return binding.root

    }

    class sendData(private var fragment: HomeFragment): AsyncTask<Void, Void, Void>() {
        var isDone = false
        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection: Connection = dbConnection().getConnection()
                if (connection != null) {
                    var query = "INSERT INTO [booking] (product_id, user_id, qty, total_price, date, status) VALUES " +
                            "('${fragment.product_id}', '${support.user_id}', '${fragment.binding.eQty.text}', '${fragment.binding.eQty.text.toString().toInt() * fragment.product_price}'," +
                            "CURRENT_TIMESTAMP, 'pending')"
                    var preparedStatement: PreparedStatement = connection.prepareStatement(query)

                    if (preparedStatement.executeUpdate() > 0) {
                        isDone = true
                    }
                }
            } catch (e: Exception) {
                support.log(e.message.toString())
            }
            return null
        }

        override fun onPostExecute(result: Void?) {
            super.onPostExecute(result)
            if (isDone) {
                fragment.context.run {
                    fragment.binding.layout.visibility = View.GONE
                }
            } else {
                support.msi(fragment as Activity, "Failed")
            }
        }
    }

    class showData(private var fragment: HomeFragment): AsyncTask<Void, Void, Void>() {
        var productList: MutableList<Product> = arrayListOf()
        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection: Connection = dbConnection().getConnection()
                if (connection != null) {
                    var query = "SELECT * FROM [product]"

                    if (fragment.binding.etSearch.text.toString() != "") {
                        query = "SELECT * FROM [product] WHERE name LIKE '%${fragment.binding.etSearch.text.toString()}%'"
                    }

                    var statement: Statement = connection.createStatement()
                    var resultSet: ResultSet = statement.executeQuery(query)

                    while (resultSet.next()) {
                        var id = resultSet.getInt("id")
                        var name = resultSet.getString("name")
                        var desc = resultSet.getString("description")
                        var price = resultSet.getInt("price")
                        var stock = resultSet.getInt("stock")
                        var image: ByteArray? = resultSet.getBytes("image")
                        var category_id = resultSet.getInt("category_id")
                        var user_id = resultSet.getInt("user_id")

                        var queryCategory = "SELECT * FROM [category] WHERE id = '$category_id'"
                        var statementCategory: Statement = connection.createStatement()
                        var resultSetCategory: ResultSet = statementCategory.executeQuery(queryCategory)

                        resultSetCategory.next()

                        var category_name = resultSetCategory.getString("name")

                        var queryUser = "SELECT * FROM [user] WHERE id = '$user_id'"
                        var statementUser: Statement = connection.createStatement()
                        var resultSetUser: ResultSet = statementUser.executeQuery(queryUser)

                        resultSetUser.next()

                        var fullname = resultSetUser.getString("fullname")

                        productList.add(Product(
                            id,
                            name,
                            desc,
                            price = price,
                            stock = stock,
                            image,
                            category =  Category(category_id,category_name),
                            user = User(user_id, fullname = fullname)
                        )

                        )
                    }
                }
            } catch (e: Exception) {
                support.log(e.message.toString())
            } catch (e: IOException) {
                support.log(e.message.toString())
            }
            return  null
        }

        override fun onPostExecute(result: Void?) {
            super.onPostExecute(result)
            fragment.context.run {
                fragment.binding.rv.adapter = ProductAdapter(fragment, productList)
                fragment.binding.rv.layoutManager = LinearLayoutManager(fragment.context)
            }

        }
    }
}