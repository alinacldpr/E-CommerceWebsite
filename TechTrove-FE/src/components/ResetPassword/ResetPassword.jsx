import React from "react";
import Userfront, { PasswordResetForm } from "@userfront/toolkit/react";

Userfront.init("demo1234");

function ResetPassword() {
  return <PasswordResetForm />;
}

export default ResetPassword;
