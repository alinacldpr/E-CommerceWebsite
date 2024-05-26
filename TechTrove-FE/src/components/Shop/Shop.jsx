// src/components/Shop/Shop.jsx
import React, { useState } from "react";
import Products from "../Products/Products";

const Shop = () => {
  const [sortOption, setSortOption] = useState("default");

  const handleSortChange = (event) => {
    setSortOption(event.target.value);
  };

  return (
    <div className="container mx-auto p-4">
      <div className="flex justify-between items-center border-b pb-4 mb-4">
        <h1 className="text-3xl font-bold">Shop</h1>
        <div className="flex items-center">
          <label htmlFor="sort" className="mr-2 text-lg">Sort by:</label>
          <select
            id="sort"
            value={sortOption}
            onChange={handleSortChange}
            className="border rounded p-2 text-lg"
          >
            <option value="default">Default</option>
            <option value="priceAsc">Price: Low to High</option>
            <option value="priceDesc">Price: High to Low</option>
            <option value="nameAsc">Name: A to Z</option>
            <option value="nameDesc">Name: Z to A</option>
          </select>
        </div>
      </div>
      <Products sortOption={sortOption} showHeading={false} />
    </div>
  );
};

export default Shop;
