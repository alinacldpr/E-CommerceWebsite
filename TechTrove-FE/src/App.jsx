import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Navbar from "./components/Navbar/Navbar";
import Hero from "./components/Hero/Hero";
import Category from "./components/Category/Category";
import Category2 from "./components/Category/Category2";
import Services from "./components/Services/Services";
import Banner from "./components/Banner/Banner";
import Products from "./components/Products/Products";
import Blogs from "./components/Blogs/Blogs";
import Smartwatch from "./components/Blogs/Smartwatch";
import Gadget from "./components/Blogs/Gadget";
import VRHeadset from "./components/Blogs/VRHeadset";
import Footer from "./components/Footer/Footer";
import Popup from "./components/Popup/Popup";
import Shop from "./components/Shop/Shop";
import About from "./components/About/About";
import Login from "./components/Login/Login";
import SignUp from "./components/Signup/Signup";
import ResetPassword from "./components/ResetPassword/ResetPassword";
import SearchResults from "./components/SearchResults/SearchResults"; // Import SearchResults component

import headphone from "./assets/hero/headphone.png";
import smartwatch2 from "./assets/category/smartwatch2-removebg-preview.png";
import AOS from "aos";
import "aos/dist/aos.css";

const BannerData = {
  discount: "30% OFF",
  title: "Fine Smile",
  date: "10 May to 10 June",
  image: headphone,
  title2: "Air Solo Bass",
  title3: "Summer Sale",
  title4:
    "Experience the best sound quality with our Air Solo Bass headphones. Limited time offer, don't miss out!",
  bgColor: "#f42c37",
};

const BannerData2 = {
  discount: "30% OFF",
  title: "Happy Hours",
  date: "20 May to 20 June",
  image: smartwatch2,
  title2: "Smart Solo",
  title3: "Summer Sale",
  title4:
    "Stay ahead with our Smart Solo watch. Track your activity and enjoy seamless connectivity. Limited time offer!",
  bgColor: "#2dcc6f",
};

const App = () => {
  const [orderPopup, setOrderPopup] = React.useState(false);

  const handleOrderPopup = () => {
    setOrderPopup(!orderPopup);
  };

  const handleSearch = (query) => {
    if (query) {
      window.location.href = `/search?query=${query}`;
    }
  };

  React.useEffect(() => {
    AOS.init({
      duration: 800,
      easing: "ease-in-sine",
      delay: 100,
      offset: 100,
    });
    AOS.refresh();
  }, []);

  return (
    <Router>
      <div className="bg-white dark:bg-gray-900 dark:text-white duration-200 overflow-hidden">
        <Navbar
          handleOrderPopup={handleOrderPopup}
          handleSearch={handleSearch}
        />
        <Routes>
          <Route
            path="/"
            element={
              <>
                <Hero handleOrderPopup={handleOrderPopup} />
                <Category />
                <Category2 />
                <Services />
                <Banner data={BannerData} />
                <Products />
                <Banner data={BannerData2} />
                <Blogs />
                <Footer />
                <Popup
                  orderPopup={orderPopup}
                  handleOrderPopup={handleOrderPopup}
                />
              </>
            }
          />
          <Route path="/shop" element={<Shop />} />
          <Route path="/about" element={<About />} />
          <Route path="/blogs" element={<Blogs />} />
          <Route path="/login" element={<Login />} />
          <Route path="/signup" element={<SignUp />} />
          <Route path="/resetpassword" element={<ResetPassword />} />
          <Route path="/blogs/smartwatch" element={<Smartwatch />} />
          <Route path="/blogs/gadget" element={<Gadget />} />
          <Route path="/blogs/vr-headset" element={<VRHeadset />} />
          <Route path="/search" element={<SearchResults />} />{" "}
          {/* Add this line */}
        </Routes>
      </div>
    </Router>
  );
};

export default App;
