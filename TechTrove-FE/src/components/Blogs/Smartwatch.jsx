import React from 'react';
import Img1 from '../../assets/blogs/blog-1.jpg';

const Smartwatch = () => {
  return (
    <div className="container mx-auto my-12">
      <h1 className="text-3xl font-bold mb-4">How to choose the perfect smartwatch</h1>
      <p>Published on Jan 20, 2024 by Dilshad</p>
      <img src={Img1} alt="Smartwatch" className="my-4 w-full h-auto" />
      <p>
        Smartwatches have evolved from simple step counters to versatile companions that can track your health, assist with daily tasks, and even replace your phone for some functions. When selecting a smartwatch, consider the following key features:
      </p>
      <h2 className="text-2xl font-semibold my-2">Compatibility</h2>
      <p>
        Ensure the smartwatch is compatible with your smartphone. Most smartwatches are designed to work with specific operating systems, such as iOS or Android. Compatibility affects the range of features available and the overall user experience.
      </p>
      <h2 className="text-2xl font-semibold my-2">Features</h2>
      <p>
        Look for features that match your needs. Common features include fitness tracking, heart rate monitoring, GPS, notifications, and apps. Some advanced models offer ECG monitoring, blood oxygen level measurement, and contactless payments.
      </p>
      <h2 className="text-2xl font-semibold my-2">Battery Life</h2>
      <p>
        Battery life can vary significantly between models. If you need a smartwatch that lasts through multiple days of heavy use, make sure to check the battery life specifications.
      </p>
      <h2 className="text-2xl font-semibold my-2">Design and Comfort</h2>
      <p>
        A smartwatch is a wearable device, so comfort and design are important. Choose a design that suits your style and feels comfortable on your wrist, especially for extended periods.
      </p>
      <h2 className="text-2xl font-semibold my-2">Price</h2>
      <p>
        Smartwatches come in a range of prices, from budget-friendly options to premium models. Determine your budget and find a model that offers the best value within that range.
      </p>
    </div>
  );
};

export default Smartwatch;
