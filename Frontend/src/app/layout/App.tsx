import { Outlet, useLocation } from "react-router-dom";
import Header from "./Header";
import { useEffect, useState } from "react";
import LoadingComponent from "../components/LoadingComponent";
import HomePage from "../../features/home/HomePage";

function App() {
  const location = useLocation();
  const [loading, setLoading] = useState(true);
  useEffect(() => {
    setLoading(false);
  }, []);

  return (
    <>
      <Header />

      {loading ? (
        <LoadingComponent message="Initialising app..." />
      ) : location.pathname === "/" ? (
        <HomePage />
      ) : (
        <main>
          <Outlet />
        </main>
      )}

      {/* ////////// TODO ////////// */}
      {/* <Footer /> */}
    </>
  );
}

export default App;
