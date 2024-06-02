// src/components/Cart/CartItemList.js
import React, { useEffect, useState } from 'react';
import CartItemService from '../Services/CartItemService';

const CartItemList = () => {
    const [cartItems, setCartItems] = useState([]);

    useEffect(() => {
        CartItemService.getAllCartItems()
            .then(response => {
                setCartItems(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the cart items!', error);
            });
    }, []);

    return (
        <div>
            <h1>Cart Item List</h1>
            <ul>
                {cartItems.map(cartItem => (
                    <li key={cartItem.id}>Cart Item ID: {cartItem.id}, Cart ID: {cartItem.techTroveCartId}, Product ID: {cartItem.techTroveProductId}, Quantity: {cartItem.quantity}, Price: {cartItem.price}</li>
                ))}
            </ul>
        </div>
    );
};

export default CartItemList;
