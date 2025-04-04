package com.example.inventtrack

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.fragment.app.Fragment
import com.example.inventtrack.databinding.ActivityMainBinding
import com.example.inventtrack.ui.activity.EditProfileActivity
import com.example.inventtrack.ui.fragment.HistoryFragment
import com.example.inventtrack.ui.fragment.HomeFragment
import com.example.inventtrack.util.support

class MainActivity : AppCompatActivity() {
    lateinit var binding: ActivityMainBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
//        enableEdgeToEdge()
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.img.setOnClickListener {
            startActivity(Intent(this, EditProfileActivity::class.java))
//            finish()
        }

        showFragment(HomeFragment())

        binding.tv.text = "Welcome, " + support.fullname + "!"

        binding.navbar.setOnNavigationItemSelectedListener {
            when (it.itemId) {
                R.id.menuHome -> {
                    showFragment(HomeFragment())
                    return@setOnNavigationItemSelectedListener true
                }

                R.id.menuHistory -> {
                    showFragment(HistoryFragment())
                    return@setOnNavigationItemSelectedListener true
                }

                else -> false
            }
        }

    }

    override fun onResume() {
        super.onResume()
        binding.tv.text = "Welcome, " + support.fullname + "!"
    }
    fun showFragment(fragment: Fragment) {
        supportFragmentManager
            .beginTransaction()
            .replace(R.id.containerFragment, fragment)
            .commit()
    }
}