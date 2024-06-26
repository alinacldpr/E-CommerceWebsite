// src/services/AuthService.js
import axios from 'axios';

const API_URL = 'https://localhost:7238/api/auth/';

class AuthService {
    async login(email, password) {
        const response = await axios.post(API_URL + 'login', { email, password });
        if (response.data.token) {
            localStorage.setItem('user', JSON.stringify(response.data));
        }
        return response.data;
    }

    logout() {
        localStorage.removeItem('user');
    }

    getCurrentUser() {
        return JSON.parse(localStorage.getItem('user'));
    }
}

export default new AuthService();
