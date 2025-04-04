package com.example.inventtrack.ui.fragment.tabLayout

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
import com.example.inventtrack.adapter.BookingAdapter
import com.example.inventtrack.databinding.FragmentFailedBinding
import com.example.inventtrack.model.Booking
import com.example.inventtrack.model.Category
import com.example.inventtrack.model.Product
import com.example.inventtrack.model.User
import com.example.inventtrack.network.dbConnection
import com.example.inventtrack.ui.fragment.tabLayout.PendingFragment.showData
import com.example.inventtrack.util.support
import java.sql.Connection
import java.sql.ResultSet
import java.sql.SQLException
import java.sql.Statement

class FailedFragment : Fragment() {
    lateinit var binding: FragmentFailedBinding
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        binding = FragmentFailedBinding.inflate(inflater, container, false)

        binding.etSearch.addTextChangedListener(object: TextWatcher {
            override fun beforeTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {

            }

            override fun onTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {
               showData(this@FailedFragment).execute()
            }

            override fun afterTextChanged(p0: Editable?) {
            }
        })

        showData(this).execute()
        return binding.root
    }

    class showData(private var fragment: FailedFragment): AsyncTask<Void, Void, Void>() {
        var bookingList: MutableList<Booking> = arrayListOf()
        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection: Connection = dbConnection().getConnection()
                if (connection != null) {
                    var query = "SELECT * FROM [booking] WHERE status = 'failed' AND user_id = ${support.user_id}"

                    if (fragment.binding.etSearch.text.toString() != "") {
                        query = "SELECT * FROM [booking] JOIN [product] ON booking.product_id = product.id WHERE booking.status = 'failed' AND booking.user_id = ${support.user_id} AND product.name LIKE '%${fragment.binding.etSearch.text.toString()}%'"
                    }

                    var statement: Statement = connection.createStatement()
                    var resultSet: ResultSet = statement.executeQuery(query)

                    while (resultSet.next()) {
                        var product_id = resultSet.getInt("product_id")
                        var qty = resultSet.getInt("qty")
                        var total_price = resultSet.getInt("total_price")
                        var date = resultSet.getString("date")
                        var status = resultSet.getString("status")

//                        var queryUser = "SELECT * FROM [user] WHERE id = ${support.user_id}"
//                        var statementUser: Statement = connection.createStatement()
//                        var resultSetUser = statementUser.executeQuery(queryUser)
//
//                        resultSetUser.next()
//
//                        var user

                        var queryProduct = "SELECT * FROM [product] WHERE id = $product_id"
                        var statementProduct: Statement = connection.createStatement()
                        var resultSetProduct: ResultSet = statementProduct.executeQuery(queryProduct)

                        resultSetProduct.next()

                        var user_id = resultSetProduct.getInt("user_id")
                        var name = resultSetProduct.getString("name")
                        var desc = resultSetProduct.getString("description")
                        var price = resultSetProduct.getInt("price")
                        var stock = resultSetProduct.getInt("stock")
                        var image: ByteArray? = resultSetProduct.getBytes("image")
                        var category_id = resultSetProduct.getInt("category_id")

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

                        bookingList.add(
                            Booking(
                                qty = qty,
                                total_price = total_price,
                                date = date,
                                status = status,
                                product = Product(name = name, description = desc, price = price, stock = stock, image = image, category = Category(category_id, name = category_name), user = User(fullname = fullname)),
                                user = User()
                            )
                        )
                    }
                }
            } catch (e: Exception) {
                support.log(e.message.toString())
            } catch (e: SQLException) {
                support.log(e.message.toString())
            }
            return null
        }

        override fun onPostExecute(result: Void?) {
            super.onPostExecute(result)
            fragment.context.run {
                fragment.binding.rv.adapter = BookingAdapter(bookingList)
                fragment.binding.rv.layoutManager = LinearLayoutManager(fragment.context)
            }

        }
    }


}