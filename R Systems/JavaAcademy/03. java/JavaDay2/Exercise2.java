package com.computaris.academy.ide.denisa;

import com.computaris.academy.ide.PC;
import com.computaris.academy.ide.os.OS;

public class Exercise2 implements OS {
    private String name;
    private String kernel;
    private String distro;

    public Exercise2() {
        this.name = "Linux";
        this.kernel = "4.4.0" ;
        this.distro = "Ubuntu 20.04.04 LTS" ;
    }

    @Override
    public String getName() {
        return toString();
    }

    @Override
    public void run(PC pc) {}

    @Override
    public String toString() {
        return "Name: " + name + "\n" +
                "Kernel:" + kernel + "\n" +
                "Distro:" + distro;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getKernel() {
        return kernel;
    }

    public void setKernel(String kernel) {
        this.kernel = kernel;
    }

    public String getDistro() {
        return distro;
    }

    public void setDistro(String distro) {
        this.distro = distro;
    }
}
