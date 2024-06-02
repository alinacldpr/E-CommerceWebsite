// src/components/Services/CartItemService.js
import axios from 'axios';

const API_URL = 'http://localhost:5000/api'; // URL-ul backend-ului tău

class CartItemService {
    getAllCartItems() {
        return axios.get(`${API_URL}/cartitems`);
    }

    getCartItemById(id) {
        return axios.get(`${API_URL}/cartitems/${id}`);
    }

    createCartItem(cartItem) {
        return axios.post(`${API_URL}/cartitems`, cartItem);
    }

    updateCartItem(id, cartItem) {
        return axios.put(`${API_URL}/cartitems/${id}`, cartItem);
    }

    deleteCartItem(id) {
        return axios.delete(`${API_URL}/cartitems/${id}`);
    }
}

export default new CartItemService();
