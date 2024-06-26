import React from 'react';
import { Link } from 'react-router-dom';
import { IoMdSearch } from 'react-icons/io';
import { FaCaretDown, FaCartShopping } from 'react-icons/fa6';
import DarkMode from './DarkMode';

const MainLinks = [
    { id: 1, name: "Home", link: "/" },
    { id: 2, name: "Shop", link: "/shop" },
    { id: 3, name: "About", link: "/about" },
    { id: 4, name: "Blogs", link: "/blogs" }
];

const AdminLinks = [
    { id: 1, name: "Users", link: "/users" },
    { id: 2, name: "Products", link: "/products" },
    { id: 3, name: "Categories", link: "/categories" },
    { id: 4, name: "Orders", link: "/orders" },
    { id: 5, name: "Order Lines", link: "/order-lines" }
];

const Navbar = () => {
    return (
        <div className="bg-white dark:bg-gray-900 dark:text-white duration-200 relative z-40">
            <div className="container mx-auto px-4">
                <div className="flex justify-between items-center py-4">
                    <div className="flex items-center gap-4">
                        <Link to="/" className="text-primary font-semibold tracking-widest text-2xl uppercase sm:text-3xl">
                            TechTrove
                        </Link>
                        <div className="hidden lg:block">
                            <ul className="flex items-center gap-4">
                                {MainLinks.map((data) => (
                                    <li key={data.id}>
                                        <Link
                                            to={data.link}
                                            className="inline-block px-4 font-semibold text-gray-500 hover:text-black dark:hover:text-white duration-200"
                                        >
                                            {data.name}
                                        </Link>
                                    </li>
                                ))}
                            </ul>
                        </div>
                    </div>
                    <div className="flex items-center gap-4">
                        <div className="relative cursor-pointer group hidden lg:block">
                            <Link
                                to="#"
                                className="flex items-center gap-[2px] font-semibold text-gray-500 dark:hover:text-white py-2"
                            >
                                Admin Links
                                <FaCaretDown className="ml-2" />
                            </Link>
                            <div className="absolute left-0 top-full mt-2 bg-white shadow-lg rounded-md overflow-hidden opacity-0 group-hover:opacity-100 transition duration-200">
                                <ul className="text-sm text-gray-700 dark:text-gray-200">
                                    {AdminLinks.map((data) => (
                                        <li key={data.id}>
                                            <Link
                                                to={data.link}
                                                className="block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-700"
                                            >
                                                {data.name}
                                            </Link>
                                        </li>
                                    ))}
                                </ul>
                            </div>
                        </div>
                        <div className="relative cursor-pointer hidden lg:block">
                            <Link to="/shopping-cart" className="relative">
                                <FaCartShopping className="text-xl text-gray-600 dark:text-gray-400" />
                                <div className="w-4 h-4 bg-red-500 text-white rounded-full absolute -top-1 -right-1 flex items-center justify-center text-xs">3</div>
                            </Link>
                        </div>
                        <Link to="/login" className="p-3 text-gray-600 dark:text-gray-400 hover:text-black dark:hover:text-white">
                            Log in
                        </Link>
                        <DarkMode />
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Navbar;
