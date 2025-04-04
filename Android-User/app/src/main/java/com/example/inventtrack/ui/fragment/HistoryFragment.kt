package com.example.inventtrack.ui.fragment

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.example.inventtrack.R
import com.example.inventtrack.adapter.ViewPageAdapter
import com.example.inventtrack.databinding.FragmentHistoryBinding
import com.example.inventtrack.databinding.FragmentHomeBinding

class HistoryFragment : Fragment() {
    lateinit var binding: FragmentHistoryBinding
    lateinit var viewPageAdapter: ViewPageAdapter
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        binding = FragmentHistoryBinding.inflate(inflater, container, false)

        viewPageAdapter = ViewPageAdapter(childFragmentManager)
        binding.viewPager.adapter = viewPageAdapter
        binding.tabLayout.setupWithViewPager(binding.viewPager)

        return binding.root
    }

}