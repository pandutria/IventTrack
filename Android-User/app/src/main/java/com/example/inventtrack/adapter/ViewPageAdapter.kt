package com.example.inventtrack.adapter

import androidx.fragment.app.Fragment
import androidx.fragment.app.FragmentManager
import androidx.fragment.app.FragmentPagerAdapter
import com.example.inventtrack.ui.fragment.tabLayout.CompletedFragment
import com.example.inventtrack.ui.fragment.tabLayout.FailedFragment
import com.example.inventtrack.ui.fragment.tabLayout.PendingFragment

class ViewPageAdapter(fragmentManager: FragmentManager):FragmentPagerAdapter(fragmentManager) {
    override fun getCount(): Int {
        return 3
    }

    override fun getItem(position: Int): Fragment {
        return when(position) {
            0 -> CompletedFragment()
            1 -> PendingFragment()
            2 -> FailedFragment()

            else -> Fragment()
        }
    }

    override fun getPageTitle(position: Int): CharSequence? {
        return when (position) {
            0 -> "Completed"
            1 -> "Pending"
            2 -> "Failed"
            else -> null
        }
    }
}