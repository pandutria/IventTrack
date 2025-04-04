package com.example.inventtrack.network

import android.os.StrictMode
import android.os.StrictMode.ThreadPolicy
import com.example.inventtrack.util.support
import java.sql.Connection
import java.sql.DriverManager

class dbConnection {
    fun getConnection(): Connection {
        var ip = "10.0.2.2"
        var port = "1433"
        var user = "pandu"
        var password ="pandu123"
        var database = "InventTrack"
        var url = ""

        var policy = ThreadPolicy
            .Builder()
            .permitAll()
            .build()

        StrictMode.setThreadPolicy(policy)

        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver")
            url = "jdbc:jtds:sqlserver://$ip:$port;databaseName=$database;user=$user;password=$password"
        } catch (e: Exception) {
            support.log(e.message.toString())
        }

        return DriverManager.getConnection(url)
    }
}