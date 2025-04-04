package com.example.inventtrack.ui.activity.auth

import android.content.Intent
import android.os.AsyncTask
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.inventtrack.R
import com.example.inventtrack.databinding.ActivityRegisterBinding
import com.example.inventtrack.network.dbConnection
import com.example.inventtrack.util.support
import java.sql.PreparedStatement

class RegisterActivity : AppCompatActivity() {
    lateinit var binding: ActivityRegisterBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
//        enableEdgeToEdge()
        binding = ActivityRegisterBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnRegister.setOnClickListener {
            regist(this).execute()
        }

    }

    class regist(private var activity: RegisterActivity): AsyncTask<Void, Void, Void>() {
        var isDone = false

        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection = dbConnection().getConnection()
                if (connection!= null) {
//                    var query = "INSERT INTO [user] VALUES username = '${activity.binding.etUsername.text}'," +
//                            "fullname = '${activity.binding.etFullname.text}', password = '${activity.binding.etPassword.text}'," +
//                            "age = '${activity.binding.etAge.text}', address = '${activity.binding.etAddress}', isAdmin = 'false'"
                    var query = "INSERT INTO [user] (username, fullname, password, age, address, isAdmin) " +
                            "VALUES ('${activity.binding.etUsername.text}', '${activity.binding.etFullname.text}', '${activity.binding.etPassword.text}'," +
                            "'${activity.binding.etAge.text}', '${activity.binding.etAddress.text}', 'false')"
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
                activity.startActivity(Intent(activity, LoginActivity::class.java))
                activity.finish()
            } else {
                support.msi(activity, "Register failed!!!")
            }
        }

    }
}