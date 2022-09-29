package com.cts.academy.profiles.bl.services.dao.interfaces;

import com.cts.academy.profiles.dal.entity.Stock;

import java.util.UUID;

public interface StockDAO {
    public Stock getStock(UUID stockId);
}
