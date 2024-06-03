// src/components/Services/CartItemService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class CartItemService {
    getAllCartItems() {
        return axios.get(`${API_URL}/CartItems`);
    }

    getCartItemById(id) {
        return axios.get(`${API_URL}/CartItems/${id}`);
    }

    createCartItem(cartItem) {
        return axios.post(`${API_URL}/CartItems`, cartItem);
    }

    updateCartItem(id, cartItem) {
        return axios.put(`${API_URL}/CartItems/${id}`, cartItem);
    }

    deleteCartItem(id) {
        return axios.delete(`${API_URL}/CartItems/${id}`);
    }
}

export default new CartItemService();
