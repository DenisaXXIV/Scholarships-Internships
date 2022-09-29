package com.cts.academy.profiles.bl.services.dao.implementation;

import com.cts.academy.profiles.bl.services.dao.interfaces.StockDAO;
import com.cts.academy.profiles.c3p0.ConnectionManager;
import com.cts.academy.profiles.dal.entity.Stock;

import java.util.List;
import java.util.UUID;

public class StockDAOimplementation implements StockDAO {
    ConnectionManager connectionManager;
    private List<Stock> stocks;

    @Override
    public Stock getStock(UUID stockId) {
        for (Stock stock: stocks) {
            if(stock.getStockID() == stockId) {
                return stock;
            }
        }
        return null;
    }

}
