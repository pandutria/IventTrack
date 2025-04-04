package com.example.inventtrack.adapter

import android.graphics.BitmapFactory
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.inventtrack.R
import com.example.inventtrack.databinding.ItemProductBinding
import com.example.inventtrack.model.Product
import com.example.inventtrack.ui.fragment.HomeFragment

class ProductAdapter(private var fragment: HomeFragment, private  var productList: List<Product>): RecyclerView.Adapter<ProductAdapter.ViewHolder>() {

    class ViewHolder(val binding: ItemProductBinding) : RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val v = ItemProductBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return ViewHolder(v)
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        var product = productList[position]
        holder.binding.tvName.text = "${product.name} (${product.category.name})"
        holder.binding.tvDesc.text = "Description : " + product.description
        holder.binding.tvPrice.text = "Price : Rp. " + product.price.toString()
        holder.binding.tvStock.text =  "Stock : " + product.stock.toString()
        holder.binding.tvAdmin.text = "Admin : " + product.user.fullname

        if (product.image != null && product.image!!.isNotEmpty()) {
            var bitmap =BitmapFactory.decodeByteArray(product.image, 0, product.image!!.size)
            holder.binding.imgImage.setImageBitmap(bitmap)
        } else {
            holder.binding.imgImage.setImageResource(R.drawable.img_8)
        }

        holder.binding.btn.setOnClickListener {
            fragment.context.run {
                fragment.binding.layout.visibility = View.VISIBLE
                fragment.product_id = product.id.toString().toInt()
                fragment.product_price = product.price.toString().toInt()
            }
        }
    }

    override fun getItemCount(): Int {
        return productList.size
    }
}