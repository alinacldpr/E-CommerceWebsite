// src/components/About/About.jsx
import React from "react";

const About = () => {
  return (
    <div className="container mx-auto p-4">
      <div className="flex justify-between items-center border-b pb-4 mb-4">
        <h1 className="text-3xl font-bold">About Us</h1>
      </div>
      <div className="space-y-4">
        <p className="text-lg">
          Welcome to TechTrove, your premier source for all things tech. We're dedicated to providing you with the best tech products, emphasizing quality, customer service, and innovation.
        </p>
        <p className="text-lg">
          Founded in 2024 by a group of passionate developers and tech enthusiasts, TechTrove has rapidly grown into a trusted name in the tech industry. Our journey began with a simple idea: to make cutting-edge technology accessible to everyone.
        </p>
        <p className="text-lg">
          At TechTrove, we believe that technology should enhance your life, making it more convenient, enjoyable, and connected. Our diverse team brings a wealth of experience from various tech backgrounds, ensuring that our products are not only top-notch but also meet the needs of a wide range of users.
        </p>
        <p className="text-lg">
          Our commitment to sustainability and innovation drives us to continuously seek out the best products and solutions. We partner with leading tech brands to bring you the latest and greatest in gadgets, accessories, and more.
        </p>
        <p className="text-lg">
          We hope you enjoy our products as much as we enjoy offering them to you. If you have any questions or comments, please don't hesitate to contact us.
        </p>
        <p className="text-lg mt-4">
          Sincerely,
          <br />
          The Dev Team
        </p>
      </div>
    </div>
  );
};

export default About;
