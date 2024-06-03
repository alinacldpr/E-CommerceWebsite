// src/components/Services/UserService.js
import axios from 'axios';

const API_URL = 'http://localhost:7238/api'; // URL-ul backend-ului tău

class UserService {
    getAllUsers() {
        return axios.get(`${API_URL}/Users`);
    }

    getUserById(id) {
        return axios.get(`${API_URL}/Users/${id}`);
    }

    createUser(user) {
        return axios.post(`${API_URL}/Users`, user);
    }

    updateUser(id, user) {
        return axios.put(`${API_URL}/Users/${id}`, user);
    }

    deleteUser(id) {
        return axios.delete(`${API_URL}/Users/${id}`);
    }
}

export default new UserService();
