// src/components/Users/UserList.js
import React, { useEffect, useState } from 'react';
import UserService from '../Services/UserService';

const UserList = () => {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        UserService.getAllUsers()
            .then(response => {
                setUsers(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the users!', error);
            });
    }, []);

    return (
        <div>
            <h1>User List</h1>
            <ul>
                {users.map(user => (
                    <li key={user.id}>{user.firstName} {user.lastName}</li>
                ))}
            </ul>
        </div>
    );
};

export default UserList;
