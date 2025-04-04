package com.example.inventtrack.util

import android.content.Context
import android.util.Log
import android.widget.Toast

object support {
    var user_id = ""
    var fullname = ""
    var username = ""
    var password = ""
    var age = 0
    var address = ""

    fun msi(context: Context, text: String) {
        Toast.makeText(context, text, Toast.LENGTH_SHORT).show()
    }

    fun log(text: String) {
        Log.d("SqlServer", "Eror : $text")
    }
}