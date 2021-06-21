// import { gql, useQuery } from "@apollo/client";
// import { Drawer, List, ListItem, ListItemText } from "@material-ui/core";
// import ApolloClient from "../interfaces/apollo-client";
// import CategoryQuery from "../models/category-query.model";
// import SideBarStyles from "../styles/sidebar";
// const CATEGORIES_QUERY = gql`
//   query {
//     categories {
//       categoryName
//     }
//   }
// `;
// function SideBarList() {
//   const { loading, error, data }: ApolloClient<CategoryQuery> =
//     useQuery(CATEGORIES_QUERY);
//   const classes = SideBarStyles();
//   let list;
//   if (loading) list = <p>loading</p>;
//   if (error) list = <p>error</p>;
//   if (!error && !loading && data) {
//     console.log(data);
//     list = (
//       <List>
//         {data.categories.map((d, index) => (
//           <ListItem button key={d.categoryName}>
//             <ListItemText primary={d.categoryName} />
//           </ListItem>
//         ))}
//       </List>
//     );
//   }
//   return (
//     <Drawer
//       className={classes.drawer}
//       variant="permanent"
//       classes={{
//         paper: classes.drawerPaper,
//       }}
//       anchor="left"
//     >
//       {list}
//     </Drawer>
//   );
// }

// export default SideBarList;
export {};
