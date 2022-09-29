package com.computaris.academy.ide.hw;

import com.computaris.academy.ide.os.OS;
import com.computaris.academy.ide.os.windows.Windows10;

public class SSD implements HWComponent, BootCapable {

    static final String BRAND = "unbranded";

    SSD(){}


    public void powerOn() {
        System.out.println("SSD: unbranded is on");
    }

    @Override
    public void powerOff() {

    }

    public OS getOS() {
        return new Windows10();
    }

}
