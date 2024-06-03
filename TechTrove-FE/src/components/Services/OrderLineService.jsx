// src/components/Services/OrderLineService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class OrderLineService {
    getAllOrderLines() {
        return axios.get(`${API_URL}/OrderLines`);
    }

    getOrderLineById(id) {
        return axios.get(`${API_URL}/OrderLines/${id}`);
    }

    createOrderLine(orderLine) {
        return axios.post(`${API_URL}/OrderLines`, orderLine);
    }

    updateOrderLine(id, orderLine) {
        return axios.put(`${API_URL}/OrderLines/${id}`, orderLine);
    }

    deleteOrderLine(id) {
        return axios.delete(`${API_URL}/OrderLines/${id}`);
    }
}

export default new OrderLineService();
