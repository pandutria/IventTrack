package com.example.inventtrack.adapter

import android.graphics.BitmapFactory
import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.inventtrack.R
import com.example.inventtrack.databinding.ItemBookingBinding
import com.example.inventtrack.model.Booking

class BookingAdapter(private var bookingList: List<Booking>): RecyclerView.Adapter<BookingAdapter.ViewHolder>() {
    class ViewHolder(var binding: ItemBookingBinding): RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val v = ItemBookingBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return ViewHolder(v)
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        var booking = bookingList[position]
        holder.binding.tvName.text = booking.product.name
        holder.binding.tvDesc.text = "Description : " + booking.product.description
        holder.binding.tvPrice.text = "Price : " + booking.product.price.toString()
        holder.binding.tvAdmin.text = "Admin : " + booking.product.user.fullname

        if (booking.product.image != null && booking.product.image!!.isNotEmpty()) {
            var bitmap = BitmapFactory.decodeByteArray(booking.product.image, 0, booking.product.image!!.size)
            holder.binding.imgImage.setImageBitmap(bitmap)
        } else {
            holder.binding.imgImage.setImageResource(R.drawable.img_8)
        }

    }

    override fun getItemCount(): Int {
        return bookingList.size
    }
}