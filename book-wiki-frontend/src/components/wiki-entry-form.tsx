import { gql, useMutation } from "@apollo/client";
import { Button } from "@material-ui/core";
const ADD_CATEGORY = gql`
  mutation UpdateCategory($categoryName: String!) {
    categoryItem(categoryName: $categoryName) {
      categoryName
    }
  }
`;

function WikiEntryForm() {
  const [addCategory] = useMutation(ADD_CATEGORY);
  return (
    <div>
      <input />
      <Button
        variant="contained"
        color="primary"
        onClick={() => addCategory({ variables: { categoryItem: "Test" } })}
      >
        Save
      </Button>
    </div>
  );
}
export default WikiEntryForm;
