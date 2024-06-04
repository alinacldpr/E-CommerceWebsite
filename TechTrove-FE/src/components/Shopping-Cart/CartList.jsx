// src/components/Cart/CartList.js
import React, { useEffect, useState } from 'react';
import CartService from '../Services/CartService';

const CartList = () => {
    const [carts, setCarts] = useState([]);

    useEffect(() => {
        CartService.getAllCarts()
            .then(response => {
                setCarts(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the carts!', error);
            });
    }, []);

    return (
        <div>
            <h1>Cart List</h1>
            <ul>
                {carts.map(cart => (
                    <li key={cart.id}>Cart ID: {cart.id}, User ID: {cart.techTroveUserId}, Created At: {cart.createdAt}</li>
                ))}
            </ul>
        </div>
    );
};

export default CartList;
