// src/components/Services/ProductService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class ProductService {
    getAllProducts() {
        return axios.get(`${API_URL}/Products`);
    }

    getProductById(id) {
        return axios.get(`${API_URL}/Products/${id}`);
    }

    createProduct(product) {
        return axios.post(`${API_URL}/Products`, product);
    }

    updateProduct(id, product) {
        return axios.put(`${API_URL}/Products/${id}`, product);
    }

    deleteProduct(id) {
        return axios.delete(`${API_URL}/Products/${id}`);
    }
}

export default new ProductService();
