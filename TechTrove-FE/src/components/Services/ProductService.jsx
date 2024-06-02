// src/components/Services/ProductService.js
import axios from 'axios';

const API_URL = 'http://localhost:5000/api'; // URL-ul backend-ului tău

class ProductService {
    getAllProducts() {
        return axios.get(`${API_URL}/products`);
    }

    getProductById(id) {
        return axios.get(`${API_URL}/products/${id}`);
    }

    createProduct(product) {
        return axios.post(`${API_URL}/products`, product);
    }

    updateProduct(id, product) {
        return axios.put(`${API_URL}/products/${id}`, product);
    }

    deleteProduct(id) {
        return axios.delete(`${API_URL}/products/${id}`);
    }
}

export default new ProductService();
