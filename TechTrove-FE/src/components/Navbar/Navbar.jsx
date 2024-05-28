import React from "react";
import { Link } from "react-router-dom";
import { IoMdSearch } from "react-icons/io";
import { FaCaretDown, FaCartShopping } from "react-icons/fa6";
import DarkMode from "./DarkMode";

const MenuLinks = [
  { id: 1, name: "Home", link: "/" },
  { id: 2, name: "Shop", link: "/shop" },
  { id: 3, name: "About", link: "/about" },
  { id: 4, name: "Blogs", link: "/blogs" },
];

const DropdownLinks = [
  { id: 1, name: "Trending Products", link: "/trending-products" },
  { id: 2, name: "Best Selling", link: "/best-selling" },
  { id: 3, name: "Top Rated", link: "/top-rated" },
];

const Navbar = ({ handleOrderPopup, handleSearch }) => {
  const searchFunction = (e) => {
    e.preventDefault();
    const query = document.getElementById('search-bar').value;
    handleSearch(query);
  };

  return (
    <div className="bg-white dark:bg-gray-900 dark:text-white duration-200 relative z-40">
      <div className="py-4">
        <div className="container flex justify-between items-center">
          <div className="flex items-center gap-4">
            <Link to="/" className="text-primary font-semibold tracking-widest text-2xl uppercase sm:text-3xl">
              TechTrove
            </Link>
            <div className="hidden lg:block">
              <ul className="flex items-center gap-4">
                {MenuLinks.map((data, index) => (
                  <li key={index}>
                    <Link to={data.link} className="inline-block px-4 font-semibold text-gray-500 hover:text-black dark:hover:text-white duration-200">
                      {data.name}
                    </Link>
                  </li>
                ))}
                <li className="relative cursor-pointer group">
                  <Link to="#" className="flex items-center gap-[2px] font-semibold text-gray-500 dark:hover:text-white py-2">
                    Quick Links
                    <span>
                      <FaCaretDown className="group-hover:rotate-180 duration-300" />
                    </span>
                  </Link>
                  <div className="absolute z-[9999] hidden group-hover:block w-[200px] rounded-md bg-white shadow-md dark:bg-gray-900 p-2 dark:text-white">
                    <ul className="space-y-2">
                      {DropdownLinks.map((data, index) => (
                        <li key={index}>
                          <Link to={data.link} className="text-gray-500 dark:hover:text-white duration-200 inline-block w/full p-2 hover:bg-primary/20 rounded-md font-semibold">
                            {data.name}
                          </Link>
                        </li>
                      ))}
                    </ul>
                  </div>
                </li>
              </ul>
            </div>
          </div>
          <div className="flex justify-between items-center gap-4">
            <div className="relative group hidden sm:block">
              <form onSubmit={searchFunction}>
                <input type="text" id="search-bar" placeholder="Search" className="search-bar" />
                <button type="submit" className="absolute top-1/2 -translate-y-1/2 right-3">
                  <IoMdSearch className="text-xl text-gray-600 group-hover:text-primary dark:text-gray-400 duration-200" />
                </button>
              </form>
            </div>
            <button className="relative p-3" onClick={handleOrderPopup}>
              <FaCartShopping className="text-xl text-gray-600 dark:text-gray-400" />
              <div className="w-4 h-4 bg-red-500 text-white rounded-full absolute top-0 right-0 flex items-center justify-center text-xs">
                4
              </div>
            </button>
            <Link to="/login" className="p-3 text-gray-600 dark:text-gray-400 hover:text-black dark:hover:text-white">
              Log in
            </Link>
            <div>
              <DarkMode />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Navbar;
