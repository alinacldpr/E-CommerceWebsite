import React, { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";

const SearchResults = () => {
  const location = useLocation();
  const [searchResults, setSearchResults] = useState([]);
  const query = new URLSearchParams(location.search).get("query");

  useEffect(() => {
    if (query) {
      const allProducts = [
        { id: 1, name: "Wireless Headphones" },
        { id: 2, name: "Smartwatch" },
        { id: 3, name: "VR Headset" },
      ];
      const results = allProducts.filter((product) =>
        product.name.toLowerCase().includes(query.toLowerCase())
      );
      setSearchResults(results);
    }
  }, [query]);

  return (
    <div className="container mx-auto p-4">
      <h1 className="text-2xl font-semibold mb-4">Search Results</h1>
      {searchResults.length > 0 ? (
        <ul>
          {searchResults.map((result) => (
            <li key={result.id}>{result.name}</li>
          ))}
        </ul>
      ) : (
        <p>No results found for `{query}`</p>
      )}
    </div>
  );
};

export default SearchResults;
