// src/components/Services/OrderService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class OrderService {
    getAllOrders() {
        return axios.get(`${API_URL}/Orders`);
    }

    getOrderById(id) {
        return axios.get(`${API_URL}/Orders/${id}`);
    }

    createOrder(order) {
        return axios.post(`${API_URL}/Orders`, order);
    }

    updateOrder(id, order) {
        return axios.put(`${API_URL}/Orders/${id}`, order);
    }

    deleteOrder(id) {
        return axios.delete(`${API_URL}/Orders/${id}`);
    }
}

export default new OrderService();
