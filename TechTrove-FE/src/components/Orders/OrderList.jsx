// src/components/Orders/OrderList.js
import React, { useEffect, useState } from 'react';
import OrderService from '../Services/OrderService';

const OrderList = () => {
    const [orders, setOrders] = useState([]);

    useEffect(() => {
        OrderService.getAllOrders()
            .then(response => {
                setOrders(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the orders!', error);
            });
    }, []);

    return (
        <div>
            <h1>Order List</h1>
            <ul>
                {orders.map(order => (
                    <li key={order.id}>Order ID: {order.id}, User ID: {order.techTroveUserId}, Created At: {order.createdTime}</li>
                ))}
            </ul>
        </div>
    );
};

export default OrderList;
