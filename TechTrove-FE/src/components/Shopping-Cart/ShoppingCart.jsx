import React, { useState } from "react";
import {
  Container,
  Grid,
  Paper,
  Typography,
  IconButton,
  Button,
  List,
  ListItem,
  ListItemText,
  ListItemSecondaryAction,
  Divider,
  Box,
  ListItemAvatar,
  Avatar,
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  TextField,
  InputAdornment,
} from "@mui/material";
import {
  Delete as DeleteIcon,
  Add as AddIcon,
  Remove as RemoveIcon,
  Person as PersonIcon,
  Home as HomeIcon,
  CreditCard as CreditCardIcon,
  DateRange as DateRangeIcon,
  Lock as LockIcon,
} from "@mui/icons-material";
import { Formik, Form, Field } from "formik";
import * as yup from "yup";

const validationSchema = yup.object({
  name: yup.string().required("Name is required"),
  address: yup.string().required("Address is required"),
  cardNumber: yup
    .string()
    .matches(/^[0-9]{16}$/, "Card number must be 16 digits")
    .required("Card number is required"),
  expiryMonth: yup
    .string()
    .matches(/^(0[1-9]|1[0-2])$/, "Invalid month")
    .required("Expiry month is required"),
  expiryYear: yup
    .string()
    .matches(/^[0-9]{2}$/, "Invalid year")
    .required("Expiry year is required"),
  cvv: yup
    .string()
    .matches(/^[0-9]{3,4}$/, "CVV must be 3 or 4 digits")
    .required("CVV is required"),
});

const ShoppingCart = () => {
  const [cartItems, setCartItems] = useState([
    {
      id: 1,
      name: "Product 1",
      price: 19.99,
      quantity: 1,
      image: "https://via.placeholder.com/150",
    },
    {
      id: 2,
      name: "Product 2",
      price: 29.99,
      quantity: 2,
      image: "https://via.placeholder.com/150",
    },
    {
      id: 3,
      name: "Product 3",
      price: 9.99,
      quantity: 1,
      image: "https://via.placeholder.com/150",
    },
  ]);

  const [open, setOpen] = useState(false);

  const handleQuantityChange = (id, quantity) => {
    setCartItems(
      cartItems.map((item) =>
        item.id === id ? { ...item, quantity: Math.max(quantity, 1) } : item
      )
    );
  };

  const handleRemoveItem = (id) => {
    setCartItems(cartItems.filter((item) => item.id !== id));
  };

  const getTotal = () => {
    return cartItems
      .reduce((acc, item) => acc + item.price * item.quantity, 0)
      .toFixed(2);
  };

  const handleClickOpen = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleSubmit = (values) => {
    console.log("Order details:", values);
    handleClose();
  };

  return (
    <Container>
      <Typography variant="h4" gutterBottom>
        Shopping Cart
      </Typography>
      <Grid container spacing={4}>
        <Grid item xs={12} md={8}>
          <Paper>
            <List>
              {cartItems.map((item) => (
                <React.Fragment key={item.id}>
                  <ListItem>
                    <ListItemAvatar>
                      <Avatar
                        variant="square"
                        src={item.image}
                        alt={item.name}
                        sx={{ width: 100, height: 100, marginRight: 2 }}
                      />
                    </ListItemAvatar>
                    <ListItemText
                      primary={item.name}
                      secondary={`$${item.price}`}
                    />
                    <Box display="flex" alignItems="center">
                      <IconButton
                        onClick={() =>
                          handleQuantityChange(item.id, item.quantity - 1)
                        }
                      >
                        <RemoveIcon />
                      </IconButton>
                      <Typography variant="body1" style={{ margin: "0 16px" }}>
                        {item.quantity}
                      </Typography>
                      <IconButton
                        onClick={() =>
                          handleQuantityChange(item.id, item.quantity + 1)
                        }
                      >
                        <AddIcon />
                      </IconButton>
                    </Box>
                    <ListItemSecondaryAction>
                      <IconButton
                        edge="end"
                        onClick={() => handleRemoveItem(item.id)}
                      >
                        <DeleteIcon />
                      </IconButton>
                    </ListItemSecondaryAction>
                  </ListItem>
                  <Divider />
                </React.Fragment>
              ))}
            </List>
          </Paper>
        </Grid>
        <Grid item xs={12} md={4}>
          <Paper style={{ padding: "16px" }}>
            <Typography variant="h6" gutterBottom>
              Order Summary
            </Typography>
            <Typography variant="body1">Total: ${getTotal()}</Typography>
            <Button
              variant="contained"
              color="primary"
              fullWidth
              style={{ marginTop: "16px" }}
              onClick={handleClickOpen}
            >
              Checkout
            </Button>
          </Paper>
        </Grid>
      </Grid>

      <Dialog open={open} onClose={handleClose}>
        <DialogTitle>Complete Your Order</DialogTitle>
        <DialogContent>
          <Formik
            initialValues={{
              name: "",
              address: "",
              cardNumber: "",
              expiryMonth: "",
              expiryYear: "",
              cvv: "",
            }}
            validationSchema={validationSchema}
            onSubmit={handleSubmit}
          >
            {({ errors, touched }) => (
              <Form>
                <Box mb={2}>
                  <Field
                    as={TextField}
                    name="name"
                    label="Name"
                    type="text"
                    fullWidth
                    variant="standard"
                    helperText={touched.name ? errors.name : ""}
                    error={touched.name && Boolean(errors.name)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <PersonIcon />
                        </InputAdornment>
                      ),
                    }}
                  />
                </Box>
                <Box mb={2}>
                  <Field
                    as={TextField}
                    name="address"
                    label="Address"
                    type="text"
                    fullWidth
                    variant="standard"
                    helperText={touched.address ? errors.address : ""}
                    error={touched.address && Boolean(errors.address)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <HomeIcon />
                        </InputAdornment>
                      ),
                    }}
                  />
                </Box>
                <Box mb={2}>
                  <Field
                    as={TextField}
                    name="cardNumber"
                    label="Card Number"
                    type="text"
                    fullWidth
                    variant="standard"
                    helperText={touched.cardNumber ? errors.cardNumber : ""}
                    error={touched.cardNumber && Boolean(errors.cardNumber)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <CreditCardIcon />
                        </InputAdornment>
                      ),
                    }}
                  />
                </Box>
                <Box display="flex" justifyContent="space-between" mb={2}>
                  <Field
                    as={TextField}
                    name="expiryMonth"
                    label="Expiry Month (MM)"
                    type="text"
                    variant="standard"
                    helperText={touched.expiryMonth ? errors.expiryMonth : ""}
                    error={touched.expiryMonth && Boolean(errors.expiryMonth)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <DateRangeIcon />
                        </InputAdornment>
                      ),
                    }}
                    style={{ marginRight: "8px" }}
                  />
                  <Field
                    as={TextField}
                    name="expiryYear"
                    label="Expiry Year (YY)"
                    type="text"
                    variant="standard"
                    helperText={touched.expiryYear ? errors.expiryYear : ""}
                    error={touched.expiryYear && Boolean(errors.expiryYear)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <DateRangeIcon />
                        </InputAdornment>
                      ),
                    }}
                    style={{ marginLeft: "8px" }}
                  />
                </Box>
                <Box mb={2}>
                  <Field
                    as={TextField}
                    name="cvv"
                    label="CVV"
                    type="password"
                    fullWidth
                    variant="standard"
                    helperText={touched.cvv ? errors.cvv : ""}
                    error={touched.cvv && Boolean(errors.cvv)}
                    InputProps={{
                      startAdornment: (
                        <InputAdornment position="start">
                          <LockIcon />
                        </InputAdornment>
                      ),
                    }}
                  />
                </Box>
                <DialogActions>
                  <Button onClick={handleClose} color="secondary">
                    Cancel
                  </Button>
                  <Button type="submit" color="primary">
                    Submit
                  </Button>
                </DialogActions>
              </Form>
            )}
          </Formik>
        </DialogContent>
      </Dialog>
    </Container>
  );
};

export default ShoppingCart;
