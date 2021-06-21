import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { AppBar, Toolbar, Typography } from "@material-ui/core";
import SideBar from "./components/sidebar";
import AppStyles from "./styles/app";

function App() {
  const classes = AppStyles();
  return (
    <div className="App">
      <AppBar position="fixed" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            Permanent drawer
          </Typography>
        </Toolbar>
      </AppBar>
      <div className={classes.drawer}>
        <SideBar></SideBar>
      </div>
      <main className={classes.content}></main>
    </div>
  );
}

export default App;
