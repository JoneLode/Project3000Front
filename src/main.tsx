import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import { RouterProvider, createBrowserRouter } from "react-router-dom";
import { Root } from "./routes/root";
import { About } from "./routes/about";
import { Profile } from "./routes/profile";
import { Admin } from "./routes/admin";

const router = createBrowserRouter([
  { path: "/", 
  element: <Root />,
  children: [
    { path: "/about", element: <About /> },
    { path: "/profile", element: <Profile />},
    { path: "/admin", element: <Admin />}
  ]
}]);

ReactDOM.createRoot(document.getElementById("root")!).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
