import { Grid } from "@mui/material";
import { Link } from "react-router-dom";

const Home = () => {
  return (
    <>
      <h2>Welcome to EKart</h2>
      <Grid container justifyContent={"flex"}>
        <Grid item>
          <Link to="/register">Don't have an account? Register</Link>
        </Grid>
      </Grid>
      <Grid container justifyContent={"flex"}>
        <Grid item>
          <Link to="/login">Existing User? Login</Link>
        </Grid>
      </Grid>
    </>
  );
};

export default Home;
