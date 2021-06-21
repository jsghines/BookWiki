import { ApolloError } from "@apollo/client";

interface ApolloClient<T> {
  loading: boolean;
  error?: ApolloError | undefined;
  data: T | undefined;
}

export default ApolloClient;
