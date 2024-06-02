// src/components/Services/CategoryService.js
import axios from 'axios';

const API_URL = 'http://localhost:5000/api'; // URL-ul backend-ului tău

class CategoryService {
    getAllCategories() {
        return axios.get(`${API_URL}/categories`);
    }

    getCategoryById(id) {
        return axios.get(`${API_URL}/categories/${id}`);
    }

    createCategory(category) {
        return axios.post(`${API_URL}/categories`, category);
    }

    updateCategory(id, category) {
        return axios.put(`${API_URL}/categories/${id}`, category);
    }

    deleteCategory(id) {
        return axios.delete(`${API_URL}/categories/${id}`);
    }
}

export default new CategoryService();
