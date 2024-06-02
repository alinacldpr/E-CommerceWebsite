// src/components/Services/UserService.js
import axios from 'axios';

const API_URL = 'http://localhost:5000/api'; // URL-ul backend-ului tău

class UserService {
    getAllUsers() {
        return axios.get(`${API_URL}/users`);
    }

    getUserById(id) {
        return axios.get(`${API_URL}/users/${id}`);
    }

    createUser(user) {
        return axios.post(`${API_URL}/users`, user);
    }

    updateUser(id, user) {
        return axios.put(`${API_URL}/users/${id}`, user);
    }

    deleteUser(id) {
        return axios.delete(`${API_URL}/users/${id}`);
    }
}

export default new UserService();
