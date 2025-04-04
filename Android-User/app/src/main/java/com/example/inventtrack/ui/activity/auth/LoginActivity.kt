package com.example.inventtrack.ui.activity.auth

import android.content.Intent
import android.os.AsyncTask
import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.inventtrack.MainActivity
import com.example.inventtrack.R
import com.example.inventtrack.databinding.ActivityLoginBinding
import com.example.inventtrack.network.dbConnection
import com.example.inventtrack.util.support
import java.sql.Connection
import java.sql.PreparedStatement
import java.sql.ResultSet
import java.sql.Statement

class LoginActivity : AppCompatActivity() {
    lateinit var binding: ActivityLoginBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
//        enableEdgeToEdge()
//        setContentView(R.layout.activity_login)
        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnLogin.setOnClickListener {
            login(this).execute()
        }

        binding.tv.setOnClickListener {
            startActivity(Intent(this, RegisterActivity::class.java))
            finish()
        }

        binding.etUsername.setText("user")
        binding.etPassword.setText("user123")


    }
    class login(private var activity: LoginActivity): AsyncTask<Void, Void, Void>() {
        var isDone = false
        override fun doInBackground(vararg p0: Void?): Void? {
            try {
                var connection: Connection = dbConnection().getConnection()
                if (connection != null) {
                    var query = "SELECT * FROM [user] WHERE username = '${activity.binding.etUsername.text}' AND password = '${activity.binding.etPassword.text}' AND isAdmin = 'false'"
                    var statement: Statement = connection.createStatement()
                    var resulSet: ResultSet = statement.executeQuery(query)

                    if (resulSet.next()) {
                        isDone = true
                        support.user_id = resulSet.getString("id")
                        support.username = resulSet.getString("username")
                        support.fullname = resulSet.getString("fullname")
                        support.age = resulSet.getInt("age")
                        support.password = resulSet.getString("password")
                        support.address = resulSet.getString("address")
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
                activity.startActivity(Intent(activity, MainActivity::class.java))
                activity.finish()
            } else {
                support.msi(activity, "Your data is not valid")
            }
        }
    }
}