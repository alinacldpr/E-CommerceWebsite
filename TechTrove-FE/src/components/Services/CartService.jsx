// src/components/Services/CartService.js
import axios from 'axios';

const API_URL = 'http://localhost:5000/api'; // URL-ul backend-ului tău

class CartService {
    getAllCarts() {
        return axios.get(`${API_URL}/carts`);
    }

    getCartById(id) {
        return axios.get(`${API_URL}/carts/${id}`);
    }

    createCart(cart) {
        return axios.post(`${API_URL}/carts`, cart);
    }

    updateCart(id, cart) {
        return axios.put(`${API_URL}/carts/${id}`, cart);
    }

    deleteCart(id) {
        return axios.delete(`${API_URL}/carts/${id}`);
    }
}

export default new CartService();
