package com.example.inventtrack.ui.activity

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity
import com.example.inventtrack.MainActivity
import com.example.inventtrack.R
import com.example.inventtrack.ui.activity.auth.LoginActivity

class OnBoardingActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
//        enableEdgeToEdge()
        setContentView(R.layout.activity_on_boarding)

        findViewById<Button>(R.id.btnOpen).setOnClickListener {
            startActivity(Intent(this, LoginActivity::class.java))
        }
    }
}