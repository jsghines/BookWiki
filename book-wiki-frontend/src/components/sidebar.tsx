import { useMutation } from "@apollo/client";
import { gql, useQuery } from "@apollo/client";
import { Drawer, List, ListItem, ListItemText } from "@material-ui/core";
import { useState } from "react";
import ApolloClient from "../interfaces/apollo-client";
import SideBarStyles from "../styles/sidebar";
import WikiEntryButton from "./wiki-entry-button";
import CategoryQueryType from "../types/category-query";
const CATEGORIES_QUERY = gql`
  query {
    categories {
      categoryName
    }
  }
`;
function SideBar() {
  const { loading, error, data } =
    useQuery<CategoryQueryType>(CATEGORIES_QUERY);
  const classes = SideBarStyles();

  let list;

  if (loading) list = <p>loading</p>;
  if (error) list = <p>error</p>;
  if (!error && !loading && data) {
    list = (
      <List>
        {data.categories.map((c, index) => (
          <ListItem button key={c.categoryName}>
            <ListItemText primary={c.categoryName} />
          </ListItem>
        ))}
      </List>
    );
  }
  return (
    <Drawer
      className={classes.drawer}
      variant="permanent"
      classes={{
        paper: classes.drawerPaper,
      }}
      anchor="left"
    >
      {list}
      <WikiEntryButton></WikiEntryButton>
    </Drawer>
  );
}

export default SideBar;
