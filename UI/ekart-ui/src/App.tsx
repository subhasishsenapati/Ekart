import { Routes, Route } from "react-router-dom";
import Home from "./pages/Home";
import Login from "./pages/Login";
import Register from "./pages/Register";
import Buyer from "./pages/Buyer";
import Seller from "./pages/Seller";
import { Toaster } from "react-hot-toast";

function App() {
  return (
    <>
      <div>
        <Toaster />
      </div>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/buyer" element={<Buyer />} />
        <Route path="/seller" element={<Seller />} />
      </Routes>
    </>
  );
}

export default App;
