// src/components/Services/CategoryService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class CategoryService {
    getAllCategories() {
        return axios.get(`${API_URL}/Categories`);
    }

    getCategoryById(id) {
        return axios.get(`${API_URL}/Categories/${id}`);
    }

    createCategory(category) {
        return axios.post(`${API_URL}/Categories`, category);
    }

    updateCategory(id, category) {
        return axios.put(`${API_URL}/Categories/${id}`, category);
    }

    deleteCategory(id) {
        return axios.delete(`${API_URL}/Categories/${id}`);
    }
}

export default new CategoryService();
