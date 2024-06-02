// src/components/Categories/CategoryList.js
import React, { useEffect, useState } from 'react';
import CategoryService from '../Services/CategoryService';

const CategoryList = () => {
    const [categories, setCategories] = useState([]);

    useEffect(() => {
        CategoryService.getAllCategories()
            .then(response => {
                setCategories(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the categories!', error);
            });
    }, []);

    return (
        <div>
            <h1>Category List</h1>
            <ul>
                {categories.map(category => (
                    <li key={category.id}>{category.name}</li>
                ))}
            </ul>
        </div>
    );
};

export default CategoryList;
