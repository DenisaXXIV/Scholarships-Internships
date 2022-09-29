package com.cts.academy.profiles.dal.entity;

import com.cts.academy.profiles.dal.interfaces.StockInterfaces;

import java.util.Objects;
import java.util.UUID;

public class Stock implements StockInterfaces {

    private UUID stockID;
    private String name;
    private int quantity;

    public Stock(UUID stockID, String name, int quantity) {
        this.stockID = stockID;
        this.name = name;
        this.quantity = quantity;
    }

    public Stock() {}

    public UUID getStockID() {
        return stockID;
    }

    public void setStockID(UUID stockID) {
        this.stockID = stockID;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Stock stock = (Stock) o;
        return quantity == stock.quantity && stockID.equals(stock.stockID) && name.equals(stock.name);
    }

    @Override
    public int hashCode() {
        return Objects.hash(stockID, name, quantity);
    }

    @Override
    public String toString() {
        return "Stock{" +
                "stockID=" + stockID +
                ", name='" + name + '\'' +
                ", quantity=" + quantity +
                '}';
    }
}
