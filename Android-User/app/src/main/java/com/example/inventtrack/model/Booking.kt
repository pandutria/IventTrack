package com.example.inventtrack.model

data class Booking(
    var id: Int? = null,
    var qty: Int? = null,
    var total_price: Int? = null,
    var date: String? = null,
    var status: String? = null,
    var product: Product,
    var user: User

)
