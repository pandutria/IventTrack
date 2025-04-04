package com.example.inventtrack.ui.activity

import android.os.AsyncTask
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.inventtrack.R
import com.example.inventtrack.databinding.ActivityEditProfileBinding
import com.example.inventtrack.network.dbConnection
import com.example.inventtrack.util.support
import java.sql.Connection
import java.sql.PreparedStatement

class EditProfileActivity : AppCompatActivity() {
    lateinit var binding: ActivityEditProfileBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        binding = ActivityEditProfileBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.back.setOnClickListener {
            finish()
        }
        binding.btnRegister.setOnClickListener {
            editData(this).execute()
        }

        binding.etUsername.setText("${support.username}")
        binding.etFullname.setText("${support.fullname}")
        binding.etPassword.setText("${support.password}")
        binding.etAge.setText("${support.age}")
        binding.etAddress.setText("${support.address}")

    }

    class editData(private var activity: EditProfileActivity):AsyncTask<Void, Void, Void>() {
        var isDone = false
        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection: Connection = dbConnection().getConnection()
                if (connection != null) {
                    var query = "UPDATE [user] SET username = '${activity.binding.etUsername.text}', fullname = '${activity.binding.etFullname.text}'," +
                            "password = '${activity.binding.etPassword.text}', age = '${activity.binding.etAge.text}', address = '${activity.binding.etAge.text}' WHERE id = '${support.user_id}'"
                    var preparedStatement: PreparedStatement = connection.prepareStatement(query)

                    if (preparedStatement.executeUpdate() > 0) {
                        isDone = true
                        support.username = activity.binding.etUsername.text.toString()
                        support.fullname = activity.binding.etFullname.text.toString()
                        support.password = activity.binding.etPassword.text.toString()
                        support.address = activity.binding.etAddress.text.toString()
                        support.age = activity.binding.etUsername.text.toString().toInt()

//                        var resultSet = preparedStatement.resultSet
//                        support.username = resultSet.getString("username")
//                        support.fullname = resultSet.getString("fullname")
//                        support.age = resultSet.getInt("age")
//                        support.password = resultSet.getString("password")
//                        support.address = resultSet.getString("address")
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
                activity.finish()

            } else {
                support.msi(activity, "Edit profile failed")
            }
        }
    }
}