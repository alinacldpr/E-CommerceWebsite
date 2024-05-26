import React from "react";
import { Link } from 'react-router-dom';
import Heading from "../Shared/Heading";

// import images
import Img1 from "../../assets/blogs/blog-1.jpg";
import Img2 from "../../assets/blogs/blog-2.jpg";
import Img3 from "../../assets/blogs/blog-3.jpg";

const BlogData = [
  {
    title: "How to choose perfect smartwatch",
    subtitle:
      "Discover the key features to look for when selecting a smartwatch that fits your lifestyle and needs...",
    published: "Jan 20, 2024 by Dilshad",
    image: Img1,
    aosDelay: "0",
    link: "/blogs/smartwatch"
  },
  {
    title: "How to choose perfect gadget",
    subtitle:
      "Explore the essential factors to consider when choosing gadgets, ensuring you make the best purchase decision...",
    published: "Jan 20, 2024 by Satya",
    image: Img2,
    aosDelay: "200",
    link: "/blogs/gadget"
  },
  {
    title: "How to choose perfect VR headset",
    subtitle:
      "Learn about the important aspects of VR headsets, from resolution to comfort, to find the ideal one for you...",
    published: "Jan 20, 2024 by Sabir",
    image: Img3,
    aosDelay: "400",
    link: "/blogs/vr-headset"
  }
];

const Blogs = () => {
  return (
    <div className="my-12">
      <div className="container">
        <Heading title="Recent News" subtitle={"Explore Our Blogs"} />
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-6 gap-y-8 sm:gap-4 md:gap-7">
          {BlogData.map((data) => (
            <div
              data-aos="fade-up"
              data-aos-delay={data.aosDelay}
              key={data.title}
              className="bg-white dark:bg-gray-900"
            >
              <div className="overflow-hidden rounded-2xl mb-2">
                <img
                  src={data.image}
                  alt={data.title}
                  className="w-full h-[220px] object-cover rounded-2xl hover:scale-105 duration-500"
                />
              </div>
              <div className="space-y-2">
                <p className="text-xs text-gray-500">{data.published}</p>
                <p className="font-bold line-clamp-1">
                  <Link to={data.link}>{data.title}</Link>
                </p>
                <p className="line-clamp-2 text-sm text-gray-600 dark:text-gray-400">
                  {data.subtitle}
                </p>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default Blogs;
