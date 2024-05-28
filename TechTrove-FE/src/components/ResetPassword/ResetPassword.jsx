import React from "react";
import Userfront, { PasswordResetForm } from "@userfront/toolkit/react";

Userfront.init("demo1234");

function ResetPassword() {
  return (
    <div style={styles.center}>
      <div style={styles.formContainer}>
        <PasswordResetForm />
      </div>
    </div>
  );
}

const styles = {
  center: {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    height: "80vh",
  },
  formContainer: {
    maxWidth: "450px", // You can adjust this width as needed
    width: "160%",
    padding: "40px", // Optional: adds padding for better appearance
    boxShadow: "0 0 10px rgba(0, 0, 0, 0.1)", // Optional: adds a slight shadow for better visibility
    borderRadius: "8px", // Optional: rounds the corners of the container
    backgroundColor: "#fff", // Optional: ensures the background is white
  },
};

export default ResetPassword;
