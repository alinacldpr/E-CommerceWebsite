// src/components/Products/Products.jsx
import React, { useState } from "react";

import Heading from "../Shared/Heading";
import ProductCard from "./ProductCard";
import { IoMdSearch } from "react-icons/io";

// images import
import Img1 from "../../assets/product/p-1.jpg";
import Img2 from "../../assets/product/p-2.jpg";
import Img3 from "../../assets/product/p-3.jpg";
import Img4 from "../../assets/product/p-4.jpg";
import Img5 from "../../assets/product/p-5.jpg";
import Img6 from "../../assets/product/p-9.jpg";
import Img7 from "../../assets/product/p-7.jpg";

export const ProductsData = [
  {
    id: 1,
    img: Img1,
    title: "Boat Headphone",
    price: 120,
    aosDelay: "0",
  },
  {
    id: 2,
    img: Img2,
    title: "Rocky Mountain",
    price: 420,
    aosDelay: "200",
  },
  {
    id: 3,
    img: Img3,
    title: "Goggles",
    price: 320,
    aosDelay: "400",
  },
  {
    id: 4,
    img: Img4,
    title: "Printed",
    price: 220,
    aosDelay: "600",
  },
];
const ProductsData2 = [
  {
    id: 5,
    img: Img5,
    title: "Boat Headphone",
    price: 120,
    aosDelay: "0",
  },
  {
    id: 6,
    img: Img6,
    title: "Rocky Mountain",
    price: 420,
    aosDelay: "200",
  },
  {
    id: 7,
    img: Img7,
    title: "Goggles",
    price: 320,
    aosDelay: "400",
  },
  {
    id: 8,
    img: Img5,
    title: "Printed",
    price: 220,
    aosDelay: "600",
  },
];

const Products = ({ sortOption, showHeading = true }) => {
  const [searchQuery, setSearchQuery] = useState("");
  const products = [...ProductsData, ...ProductsData2];

  const filteredProducts = products.filter((product) =>
    product.title.toLowerCase().includes(searchQuery.toLowerCase())
  );

  const sortedProducts = filteredProducts.sort((a, b) => {
    switch (sortOption) {
      case "priceAsc":
        return a.price - b.price;
      case "priceDesc":
        return b.price - a.price;
      case "nameAsc":
        return a.title.localeCompare(b.title);
      case "nameDesc":
        return b.title.localeCompare(a.title);
      default:
        return 0;
    }
  });

  return (
    <div className="container mx-auto">
      {showHeading && (
        <Heading title="Our Products" subtitle="Explore Our Products" />
      )}

      <div
        className="search-bar"
        style={{
          display: "flex",
          justifyContent: "flex-end",
          marginBottom: "25px",
          width: "100%",
        }}
      >
        <input
          type="text"
          value={searchQuery}
          onChange={(e) => setSearchQuery(e.target.value)}
          placeholder="Search products by name..."
          className="search-input"
          style={{
            padding: "10px",
            border: "1px solid #ccc",
            borderRadius: "5px",
            width: "44.5%",
            marginRight: "26px",
          }}
        />
      </div>

      <div className="product-list">
        <ProductCard data={sortedProducts} />
      </div>
    </div>
  );
};

export default Products;
