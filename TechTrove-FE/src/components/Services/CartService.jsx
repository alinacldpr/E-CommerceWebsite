// src/components/Services/CartService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class CartService {
    getAllCarts() {
        return axios.get(`${API_URL}/Carts`);
    }

    getCartById(id) {
        return axios.get(`${API_URL}/Carts/${id}`);
    }

    createCart(cart) {
        return axios.post(`${API_URL}/Carts`, cart);
    }

    updateCart(id, cart) {
        return axios.put(`${API_URL}/Carts/${id}`, cart);
    }

    deleteCart(id) {
        return axios.delete(`${API_URL}/Carts/${id}`);
    }
}

export default new CartService();
