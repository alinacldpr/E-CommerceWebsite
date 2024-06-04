// src/components/Orders/OrderLineList.js
import React, { useEffect, useState } from 'react';
import OrderLineService from '../Services/OrderLineService';

const OrderLineList = () => {
    const [orderLines, setOrderLines] = useState([]);

    useEffect(() => {
        OrderLineService.getAllOrderLines()
            .then(response => {
                setOrderLines(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the order lines!', error);
            });
    }, []);

    return (
        <div>
            <h1>Order Line List</h1>
            <ul>
                {orderLines.map(orderLine => (
                    <li key={orderLine.id}>Order Line ID: {orderLine.id}, Order ID: {orderLine.techTroveOrderId}, Product ID: {orderLine.techTroveProductId}, Quantity: {orderLine.quantity}, Price: {orderLine.price}</li>
                ))}
            </ul>
        </div>
    );
};

export default OrderLineList;
