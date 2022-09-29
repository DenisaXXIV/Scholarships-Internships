package com.cts.academy.profiles.bl.services;

import com.cts.academy.profiles.bl.services.dao.implementation.StockDAOimplementation;
import com.cts.academy.profiles.dal.entity.Stock;
import com.cts.academy.profiles.dal.enums.Companies;
import com.cts.academy.profiles.bl.services.dao.interfaces.StockDAO;

import java.util.List;
import java.util.UUID;

public class StockServices {
    private StockDAOimplementation stockDAOimplementation;

    public StockServices(StockDAOimplementation stockDAOimplementation) {
        this.stockDAOimplementation = stockDAOimplementation;
    }

    public double getPrice(UUID id) {
        Stock stock = stockDAOimplementation.getStock(id);
        Companies company = Companies.valueOf(stock.getName().toLowerCase());

        return stock.getQuantity() * company.getPrice();
    }
}
