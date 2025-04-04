package com.example.inventtrack.model

data class Product(
    var id: Int? = null,
    var name: String? = null,
    var description: String? = null,
    var price: Int? = null,
    var stock: Int? = null,
    var image: ByteArray? = null,
    var user: User,
    var category: Category

)
