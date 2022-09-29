package com.cts.academy.profiles.dal.enums;

public enum Companies {
    nokia(4.42),
    oracle(65.94),
    hp(37.14),
    microsoft(247.65),
    amazon(11.1),
    vodafone(11.90);

    private double price;

    Companies(double price) {
        this.price = price;
    }

    public double getPrice() {
        return this.price;
    }
}
