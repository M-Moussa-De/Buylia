import { createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../features/home/HomePage";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    children: [
      // {
      //   element: <RequireAuth />,
      //   children: [
      //     { path: "checkout", element: <CheckoutWrapper />},
      //     { path: "orders", element: <Orders />},
      // ],
      // },
      { path: "/", element: <HomePage /> },
      // { path: "catalog/:id", element: <ProductDetails /> },
      // { path: "about", element: <AboutPage /> },
      // { path: "contact", element: <ContactPage /> },
      // { path: "basket", element: <BasketPage /> },
      // { path: "login", element: <Login /> },
      // { path: "register", element: <Register /> },
      // { path: "server-error", element: <ServerError /> },
      // { path: "not-found", element: <NotFound /> },
      // { path: "*", element: <Navigate replace to="/not-found" /> },
    ],
  },
]);
